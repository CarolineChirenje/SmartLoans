using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class NewTableRoleMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoleMenus",
                columns: table => new
                {
                    RoleMenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    MenuID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenus", x => x.RoleMenuID);
                    table.ForeignKey(
                        name: "FK_RoleMenus_Menus_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menus",
                        principalColumn: "MenuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleMenus_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 462, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 462, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 462, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 462, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 474, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 474, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 474, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 474, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 474, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 481, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 466, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 476, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 476, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 476, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 476, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.InsertData(
                table: "CustomSettings",
                columns: new[] { "CustomSettingID", "CustomSettingTypeID", "CustomVariableTypeID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name", "Value" },
                values: new object[] { 39, 3, 1, "Display menus based on User Role", true, "SuperUser", new DateTime(2020, 9, 23, 10, 21, 5, 507, DateTimeKind.Local).AddTicks(2482), "Application Role Based Menus", "false" });

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 491, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 491, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 491, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 491, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 491, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 491, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 493, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 493, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 493, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 493, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 503, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 503, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 503, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 503, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 488, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 488, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 488, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 478, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 478, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 495, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 495, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 495, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 495, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 495, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 495, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 495, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 498, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 455, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 455, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 455, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 455, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 455, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 450, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(944), "Add Menu To Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(950), "Remove Menu From Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(956), "Add Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(962), "Update Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(967), "Delete Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(973), "View Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(980), "Add Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(986), "Update Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(991), "Delete Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(998), "View Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1004), "Respond To Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1010), "Route Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1017), "Suspend Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1022), "Close Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1028), "Capture Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1034), "Refund Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1049), "Reverse Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1056), "Void Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1063), "View Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1068), "Make Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1073), "Add Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1078), "Update Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1084), "Activate Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1090), "Deactivate Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1096), "Delete Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1102), "View Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1108), "Add Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1116), "Update Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1124), "Delete Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1130), "View Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1137), "Update Custom Setting" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1143), "View Custom Setting" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1148), "Add Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1154), "Update Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1159), "Delete Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1165), "View Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1172), "Add Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1178), "Update Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1184), "Delete Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1309), "View Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1317), "Add Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1323), "Update Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1329), "Delete Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1335), "View Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1341), "Add Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1347), "Update Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1354), "Delete Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1360), "View Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1366), "Add Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1373), "Update Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1379), "Delete Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1384), "View Notice" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 102, null, true, false, "SuperUser", new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1389), "Update Country" },
                    { 103, null, true, false, "SuperUser", new DateTime(2020, 9, 23, 10, 21, 5, 451, DateTimeKind.Local).AddTicks(1394), "Update Currency" }
                });

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 482, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 482, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 482, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 482, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 470, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 470, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 470, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 470, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 470, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 475, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 475, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 475, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 475, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 475, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 443, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 477, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 477, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 477, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 477, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 477, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 477, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 477, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 477, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 477, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 459, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 459, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 459, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 459, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 459, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 459, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 494, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 494, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 473, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 473, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 473, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 473, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 483, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 486, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 486, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 23, 10, 21, 5, 486, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[] { 102, "SuperUser", new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(762), 102, 1 });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[] { 103, "SuperUser", new DateTime(2020, 9, 23, 10, 21, 5, 452, DateTimeKind.Local).AddTicks(764), 103, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenus_MenuID",
                table: "RoleMenus",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenus_RoleID",
                table: "RoleMenus",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleMenus");

            migrationBuilder.DeleteData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 527, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 527, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 527, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 527, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 542, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 542, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 542, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 542, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 542, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 551, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 531, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 544, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 544, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 544, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 544, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 582, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 565, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 565, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 565, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 565, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 565, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 565, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 568, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 569, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 569, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 569, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 578, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 578, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 578, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 578, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 562, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 562, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 562, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 547, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 547, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 571, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 571, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 571, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 571, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 571, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 571, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 571, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 573, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 519, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 520, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 520, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 520, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 520, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7369), "Add Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7373), "Update Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7377), "Delete Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7381), "View Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7386), "Add Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7390), "Update Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7394), "Delete Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7398), "View Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7403), "Respond To Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7407), "Route Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7411), "Suspend Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7415), "Close Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7418), "Capture Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7422), "Refund Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7427), "Reverse Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7431), "Void Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7437), "View Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7441), "Make Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7445), "Add Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7481), "Update Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7486), "Activate Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7490), "Deactivate Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7494), "Delete Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7498), "View Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7502), "Add Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7506), "Update Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7510), "Delete Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7514), "View Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7519), "Update Custom Setting" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7523), "View Custom Setting" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7527), "Add Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7531), "Update Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7536), "Delete Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7540), "View Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7544), "Add Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7548), "Update Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7552), "Delete Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7556), "View Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7560), "Add Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7564), "Update Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7569), "Delete Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7573), "View Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7578), "Add Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7582), "Update Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7586), "Delete Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7590), "View Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7594), "Add Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7598), "Update Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7602), "Delete Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7606), "View Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7610), "Update Country" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 22, 20, 15, 24, 515, DateTimeKind.Local).AddTicks(7614), "Update Currency" });

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 553, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 553, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 553, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 553, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 536, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 536, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 536, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 536, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 536, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 543, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 543, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 543, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 543, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 543, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 516, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 507, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 546, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 546, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 546, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 546, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 546, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 546, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 546, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 546, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 546, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 524, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 524, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 524, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 524, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 524, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 524, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 569, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 569, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 540, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 540, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 540, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 540, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 554, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 558, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 558, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 22, 20, 15, 24, 558, DateTimeKind.Local).AddTicks(5149));
        }
    }
}
