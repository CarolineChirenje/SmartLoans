using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class CourseSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceRegisters_CourseOutlines_CourseOutlineID",
                table: "AttendanceRegisters");

            migrationBuilder.DropTable(
                name: "CourseOutlines");

            migrationBuilder.DropIndex(
                name: "IX_AttendanceRegisters_CourseOutlineID",
                table: "AttendanceRegisters");

            migrationBuilder.DropColumn(
                name: "CourseOutlineID",
                table: "ClientTranscripts");

            migrationBuilder.DropColumn(
                name: "CourseOutlineID",
                table: "AttendanceRegisters");

            migrationBuilder.AddColumn<int>(
                name: "CourseTopicID",
                table: "ClientTranscripts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseTopicID",
                table: "AttendanceRegisters",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseTopics",
                columns: table => new
                {
                    CourseTopicID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    CourseID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTopics", x => x.CourseTopicID);
                    table.ForeignKey(
                        name: "FK_CourseTopics_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseSessions",
                columns: table => new
                {
                    CourseSessionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    CourseTopicID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSessions", x => x.CourseSessionID);
                    table.ForeignKey(
                        name: "FK_CourseSessions_CourseTopics_CourseTopicID",
                        column: x => x.CourseTopicID,
                        principalTable: "CourseTopics",
                        principalColumn: "CourseTopicID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 484, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 484, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 484, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 484, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 550, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 550, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 556, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 556, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 493, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 493, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 493, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 493, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 493, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 500, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 487, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 537, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 567, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 567, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 567, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 514, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 514, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 514, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 514, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 514, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 514, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 518, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 518, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 518, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 518, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 533, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 532, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 532, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 532, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 532, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 511, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 511, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 511, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 490, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 490, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 497, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 497, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 559, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 559, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 559, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 559, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 564, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 564, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 564, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 564, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 564, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 564, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 564, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 564, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 564, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 564, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 564, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 564, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 562, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 562, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 521, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 521, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 521, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 521, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 521, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 521, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 521, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 521, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 525, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 478, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 478, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 478, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 478, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 478, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 474, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 504, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 504, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 504, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 504, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 553, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 553, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 553, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 494, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 494, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 494, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 494, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 494, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 494, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 494, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 538, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 469, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 470, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 470, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 543, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 544, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 544, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 544, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 570, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 570, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 570, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 570, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 570, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 570, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 546, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 547, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 547, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 547, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 547, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 547, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 481, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 481, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 481, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 481, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 481, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 481, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 481, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 481, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 518, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 518, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 492, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 492, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 492, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 505, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 508, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 508, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 497, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 497, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 497, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 497, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 497, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 497, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 497, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 497, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 11, 29, 9, 497, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRegisters_CourseTopicID",
                table: "AttendanceRegisters",
                column: "CourseTopicID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessions_CourseTopicID",
                table: "CourseSessions",
                column: "CourseTopicID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTopics_CourseID",
                table: "CourseTopics",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceRegisters_CourseTopics_CourseTopicID",
                table: "AttendanceRegisters",
                column: "CourseTopicID",
                principalTable: "CourseTopics",
                principalColumn: "CourseTopicID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceRegisters_CourseTopics_CourseTopicID",
                table: "AttendanceRegisters");

            migrationBuilder.DropTable(
                name: "CourseSessions");

            migrationBuilder.DropTable(
                name: "CourseTopics");

            migrationBuilder.DropIndex(
                name: "IX_AttendanceRegisters_CourseTopicID",
                table: "AttendanceRegisters");

            migrationBuilder.DropColumn(
                name: "CourseTopicID",
                table: "ClientTranscripts");

            migrationBuilder.DropColumn(
                name: "CourseTopicID",
                table: "AttendanceRegisters");

            migrationBuilder.AddColumn<int>(
                name: "CourseOutlineID",
                table: "ClientTranscripts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseOutlineID",
                table: "AttendanceRegisters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseOutlines",
                columns: table => new
                {
                    CourseOutlineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastChangedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseOutlines", x => x.CourseOutlineID);
                    table.ForeignKey(
                        name: "FK_CourseOutlines_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 187, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 187, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 187, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 187, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 267, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 268, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 274, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 274, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 203, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 203, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 203, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 203, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 203, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 191, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 191, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 191, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 191, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 191, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 191, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 191, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 285, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 285, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 285, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 230, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 230, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 230, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 230, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 230, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 230, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 234, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 234, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 234, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 234, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 248, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 247, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 247, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 247, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 247, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 227, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 227, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 227, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 196, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 196, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 210, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 210, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 277, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 277, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 277, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 277, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 280, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 280, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 177, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 177, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 177, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 177, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 177, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 218, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 218, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 218, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 218, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 271, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 271, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 271, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 204, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 204, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 204, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 204, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 204, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 204, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 204, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 166, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 168, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 168, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 261, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 261, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 261, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 261, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 287, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 287, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 287, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 287, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 287, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 287, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 264, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 264, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 264, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 264, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 264, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 264, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 234, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 234, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 201, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 201, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 201, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 220, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 223, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 223, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRegisters_CourseOutlineID",
                table: "AttendanceRegisters",
                column: "CourseOutlineID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseOutlines_CourseID",
                table: "CourseOutlines",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceRegisters_CourseOutlines_CourseOutlineID",
                table: "AttendanceRegisters",
                column: "CourseOutlineID",
                principalTable: "CourseOutlines",
                principalColumn: "CourseOutlineID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
