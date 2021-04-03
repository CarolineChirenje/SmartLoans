using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class AttendanceRegister : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttendanceRegisters",
                columns: table => new
                {
                    AttendanceRegisterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    CourseIntakeID = table.Column<int>(nullable: false),
                    CourseOutlineID = table.Column<int>(nullable: true),
                    AttendanceDate = table.Column<string>(nullable: true),
                    RequestedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceRegisters", x => x.AttendanceRegisterID);
                    table.ForeignKey(
                        name: "FK_AttendanceRegisters_CourseIntakes_CourseIntakeID",
                        column: x => x.CourseIntakeID,
                        principalTable: "CourseIntakes",
                        principalColumn: "CourseIntakeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendanceRegisters_CourseOutlines_CourseOutlineID",
                        column: x => x.CourseOutlineID,
                        principalTable: "CourseOutlines",
                        principalColumn: "CourseOutlineID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceRegisterDetails",
                columns: table => new
                {
                    AttendanceRegisterDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    AttendanceRegisterID = table.Column<int>(nullable: false),
                    ClientID = table.Column<int>(nullable: false),
                    Present = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceRegisterDetails", x => x.AttendanceRegisterDetailID);
                    table.ForeignKey(
                        name: "FK_AttendanceRegisterDetails_AttendanceRegisters_AttendanceRegisterID",
                        column: x => x.AttendanceRegisterID,
                        principalTable: "AttendanceRegisters",
                        principalColumn: "AttendanceRegisterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendanceRegisterDetails_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 899, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 899, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 899, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 899, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 962, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 962, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 911, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 911, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 911, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 911, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 911, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 920, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 903, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 913, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 913, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 913, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 913, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 951, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 933, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 933, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 933, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 933, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 933, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 933, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 936, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 936, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 936, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 936, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 948, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 947, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 947, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 947, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 947, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 929, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 929, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 929, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 906, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 906, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 916, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 916, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 939, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 939, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 939, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 939, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 939, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 939, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 939, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 942, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 891, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 891, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 891, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 891, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 891, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 126, null, true, false, "SuperUser", new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9914), "Generate Attendance Register" },
                    { 125, null, true, false, "SuperUser", new DateTime(2021, 4, 3, 19, 29, 9, 886, DateTimeKind.Local).AddTicks(9908), "View Course Intake Register" }
                });

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 921, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 921, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 921, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 921, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 964, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 964, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 964, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 912, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 912, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 912, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 912, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 912, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 912, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 912, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 952, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 887, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 888, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 888, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 888, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 888, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 888, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 888, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 879, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 880, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 880, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 956, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 956, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 915, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 915, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 915, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 915, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 915, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 915, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 915, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 915, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 915, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 959, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 959, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 959, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 959, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 959, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 959, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 895, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 895, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 895, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 895, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 895, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 895, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 895, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 895, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 937, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 937, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 910, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 910, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 910, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 922, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 925, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 3, 19, 29, 9, 925, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[] { 125, "SuperUser", new DateTime(2021, 4, 3, 19, 29, 9, 888, DateTimeKind.Local).AddTicks(14), 125, 1 });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[] { 126, "SuperUser", new DateTime(2021, 4, 3, 19, 29, 9, 888, DateTimeKind.Local).AddTicks(16), 126, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRegisterDetails_AttendanceRegisterID",
                table: "AttendanceRegisterDetails",
                column: "AttendanceRegisterID");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRegisterDetails_ClientID",
                table: "AttendanceRegisterDetails",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRegisters_CourseIntakeID",
                table: "AttendanceRegisters",
                column: "CourseIntakeID");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRegisters_CourseOutlineID",
                table: "AttendanceRegisters",
                column: "CourseOutlineID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendanceRegisterDetails");

            migrationBuilder.DropTable(
                name: "AttendanceRegisters");

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 399, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 399, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 399, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 399, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 446, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 446, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 406, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 406, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 406, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 406, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 406, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 411, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 401, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 407, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 407, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 407, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 407, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 418, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 418, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 418, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 418, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 418, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 418, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 420, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 420, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 420, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 420, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 432, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 431, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 431, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 431, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 431, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 416, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 416, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 416, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 404, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 404, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 409, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 409, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 422, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 422, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 422, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 422, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 422, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 422, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 422, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 424, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 425, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 393, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 393, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 393, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 393, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 393, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 412, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 412, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 412, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 412, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 448, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 448, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 448, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 407, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 407, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 407, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 407, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 407, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 407, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 407, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 437, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 384, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 385, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 385, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 442, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 442, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 408, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 408, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 408, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 408, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 408, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 408, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 408, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 408, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 408, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 444, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 444, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 444, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 444, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 444, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 444, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 396, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 397, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 397, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 397, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 397, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 397, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 397, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 397, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 421, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 421, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 406, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 406, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 406, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 412, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 414, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 21, 48, 16, 414, DateTimeKind.Local).AddTicks(6723));
        }
    }
}
