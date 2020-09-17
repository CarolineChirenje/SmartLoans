using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class RenameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientCourseTranscripts");

            migrationBuilder.CreateTable(
                name: "CourseTranscripts",
                columns: table => new
                {
                    CourseTranscriptID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientCourseID = table.Column<int>(nullable: false),
                    CourseOutlineID = table.Column<int>(nullable: false),
                    IsDeRegistered = table.Column<bool>(nullable: false),
                    DateRegistered = table.Column<DateTime>(nullable: true),
                    DateCompleted = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTranscripts", x => x.CourseTranscriptID);
                    table.ForeignKey(
                        name: "FK_CourseTranscripts_ClientCourses_ClientCourseID",
                        column: x => x.ClientCourseID,
                        principalTable: "ClientCourses",
                        principalColumn: "ClientCourseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 498, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 498, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 498, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 498, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 510, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 510, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 510, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 510, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 510, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 516, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 501, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 511, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 511, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 511, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 511, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 547, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 530, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 530, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 530, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 530, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 530, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 530, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 532, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 532, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 532, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 543, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 543, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 543, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 526, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 527, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 527, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 513, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 513, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 535, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 535, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 535, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 535, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 535, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 535, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 535, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 537, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 493, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 493, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 493, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 493, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 493, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 489, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 517, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 517, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 517, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 517, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 506, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 506, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 506, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 506, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 506, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 511, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 511, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 511, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 511, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 511, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 490, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 481, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 513, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 513, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 513, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 513, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 513, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 513, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 513, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 513, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 513, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 495, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 496, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 496, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 496, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 496, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 533, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 533, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 509, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 509, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 509, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 509, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 518, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 522, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 522, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 51, 25, 522, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.CreateIndex(
                name: "IX_CourseTranscripts_ClientCourseID",
                table: "CourseTranscripts",
                column: "ClientCourseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseTranscripts");

            migrationBuilder.CreateTable(
                name: "ClientCourseTranscripts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientCourseID = table.Column<int>(type: "int", nullable: false),
                    CourseOutlineID = table.Column<int>(type: "int", nullable: false),
                    DateCompleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateRegistered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastChangedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCourseTranscripts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClientCourseTranscripts_ClientCourses_ClientCourseID",
                        column: x => x.ClientCourseID,
                        principalTable: "ClientCourses",
                        principalColumn: "ClientCourseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 136, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 136, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 136, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 136, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 147, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 147, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 147, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 147, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 147, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 155, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 140, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 141, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 141, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 141, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 150, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 150, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 150, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 150, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 184, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 166, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 166, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 166, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 166, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 166, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 166, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 170, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 170, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 170, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 180, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 180, DateTimeKind.Local).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 180, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 163, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 163, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 163, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 152, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 152, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 172, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 172, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 172, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 172, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 172, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 172, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 172, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 174, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 128, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 128, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 128, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 128, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 128, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 123, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 156, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 156, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 156, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 156, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 143, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 143, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 143, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 143, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 143, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 149, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 149, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 149, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 149, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 149, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 124, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 113, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 151, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 151, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 151, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 151, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 151, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 151, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 151, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 151, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 151, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 132, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 132, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 132, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 132, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 132, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 170, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 170, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 146, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 146, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 146, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 146, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 157, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 160, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 160, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 17, 19, 32, 49, 160, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.CreateIndex(
                name: "IX_ClientCourseTranscripts_ClientCourseID",
                table: "ClientCourseTranscripts",
                column: "ClientCourseID");
        }
    }
}
