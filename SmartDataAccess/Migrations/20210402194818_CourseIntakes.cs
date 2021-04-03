using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class CourseIntakes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseIntakeID",
                table: "ClientCourses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseIntakes",
                columns: table => new
                {
                    CourseIntakeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    CourseID = table.Column<int>(nullable: false),
                    MaximumCapacity = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseIntakes", x => x.CourseIntakeID);
                    table.ForeignKey(
                        name: "FK_CourseIntakes_Courses_CourseID",
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

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 118, null, true, false, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2418), "Update Course Outline" },
                    { 119, null, true, false, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2424), "Delete Course Outline" },
                    { 120, null, true, false, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2430), "View Course Outline" },
                    { 121, null, true, false, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2478), "Add Course Intake" },
                    { 122, null, true, false, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2484), "Update Course Intake" },
                    { 123, null, true, false, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2490), "Delete Course Intake" },
                    { 124, null, true, false, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2495), "View Course Intake" },
                    { 117, null, true, false, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 390, DateTimeKind.Local).AddTicks(2413), "Add Course Outline" }
                });

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

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[,]
                {
                    { 117, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(366), 117, 1 },
                    { 118, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(368), 118, 1 },
                    { 119, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(371), 119, 1 },
                    { 120, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(373), 120, 1 },
                    { 121, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(375), 121, 1 },
                    { 122, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(377), 122, 1 },
                    { 123, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(379), 123, 1 },
                    { 124, "SuperUser", new DateTime(2021, 4, 2, 21, 48, 16, 391, DateTimeKind.Local).AddTicks(382), 124, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientCourses_CourseIntakeID",
                table: "ClientCourses",
                column: "CourseIntakeID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseIntakes_CourseID",
                table: "CourseIntakes",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCourses_CourseIntakes_CourseIntakeID",
                table: "ClientCourses",
                column: "CourseIntakeID",
                principalTable: "CourseIntakes",
                principalColumn: "CourseIntakeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientCourses_CourseIntakes_CourseIntakeID",
                table: "ClientCourses");

            migrationBuilder.DropTable(
                name: "CourseIntakes");

            migrationBuilder.DropIndex(
                name: "IX_ClientCourses_CourseIntakeID",
                table: "ClientCourses");

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124);

            migrationBuilder.DropColumn(
                name: "CourseIntakeID",
                table: "ClientCourses");

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 728, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 728, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 728, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 728, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 773, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 773, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 734, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 734, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 734, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 734, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 734, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 739, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 730, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 736, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 736, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 736, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 736, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 763, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 748, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 748, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 748, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 748, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 748, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 748, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 750, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 751, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 751, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 751, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 760, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 760, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 760, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 760, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 760, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 746, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 746, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 746, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 732, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 732, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 737, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 737, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 752, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 752, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 752, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 752, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 752, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 752, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 752, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 755, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 724, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 724, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 724, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 724, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 724, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 721, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 740, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 740, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 740, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 740, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 775, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 775, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 775, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 735, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 735, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 735, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 735, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 735, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 735, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 735, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 764, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 722, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 716, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 717, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 717, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 768, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 769, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 736, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 736, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 736, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 736, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 736, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 736, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 736, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 736, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 736, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 771, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 771, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 771, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 771, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 771, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 771, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 726, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 726, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 726, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 726, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 726, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 726, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 726, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 726, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 751, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 751, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 734, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 734, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 734, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 741, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 743, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 2, 8, 28, 38, 743, DateTimeKind.Local).AddTicks(9706));
        }
    }
}
