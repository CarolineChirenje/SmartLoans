using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class LayOutComponents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Layouts",
                columns: table => new
                {
                    LayoutID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Layouts", x => x.LayoutID);
                });

            migrationBuilder.CreateTable(
                name: "LayoutMenus",
                columns: table => new
                {
                    LayoutMenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    LayoutID = table.Column<int>(nullable: false),
                    DisplayName = table.Column<string>(nullable: true),
                    ControllerName = table.Column<string>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    CSSClass = table.Column<string>(nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LayoutMenus", x => x.LayoutMenuID);
                    table.ForeignKey(
                        name: "FK_LayoutMenus_Layouts_LayoutID",
                        column: x => x.LayoutID,
                        principalTable: "Layouts",
                        principalColumn: "LayoutID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 221, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 221, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 221, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 221, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 298, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 298, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 307, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 307, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 231, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 231, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 231, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 231, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 231, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 238, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 223, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 233, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 233, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 233, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 233, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 254, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 254, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 254, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 254, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 254, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 254, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 258, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 258, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 258, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 258, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 273, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 272, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 272, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 272, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 272, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 249, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 249, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 249, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 226, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 227, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 235, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 235, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 313, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 313, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 313, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 313, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.InsertData(
                table: "Layouts",
                columns: new[] { "LayoutID", "DisplayName", "LastChangedBy", "LastChangedDate" },
                values: new object[,]
                {
                    { 2, "Products", "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 318, DateTimeKind.Local).AddTicks(8242) },
                    { 1, "Client", "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 318, DateTimeKind.Local).AddTicks(7382) }
                });

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 263, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 263, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 263, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 263, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 263, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 263, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 263, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 263, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 212, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 212, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 212, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 212, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 212, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 206, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 207, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 239, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 240, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 240, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 303, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 303, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 303, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 232, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 232, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 232, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 232, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 232, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 232, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 232, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 208, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 196, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 199, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 199, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 289, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 289, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 234, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 234, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 234, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 234, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 234, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 234, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 234, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 234, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 234, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 293, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 293, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 293, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 293, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 293, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 293, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 217, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 218, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 218, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 218, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 218, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 218, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 218, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 218, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 259, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 259, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 230, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 230, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 230, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 240, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 244, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 244, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.InsertData(
                table: "LayoutMenus",
                columns: new[] { "LayoutMenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "LayoutID", "OrderNo" },
                values: new object[,]
                {
                    { 1, "ViewProducts", "fa fa-product-hunt", "Client", "Products", true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4628), 1, 1 },
                    { 2, "ViewTransactions", "fa fa-cc-mastercard", "Client", "Payments File", true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4933), 1, 2 },
                    { 3, "ViewPendingTransactions", "fa fa-credit-card-alt", "Client", "Outstanding Payments", true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4946), 1, 3 },
                    { 4, "GenerateStatement", "fa fa-file", "Client", "Statements", true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4954), 1, 4 },
                    { 5, "ViewCourses", "fa fa-graduation-cap", "Client", "Coaching Programmes", true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4963), 1, 5 },
                    { 6, "ViewNotes", "fa fa-comments", "Client", "Notes", true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4980), 1, 6 },
                    { 7, "Documents", "fa fa-book", "Client", "Documents", true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4988), 1, 7 },
                    { 8, "ViewDependents", "fa fa-child", "Client", "Dependents", true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4998), 1, 8 },
                    { 9, "ViewContacts", "fa fa-address-book", "Client", "Contacts", true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(5006), 1, 9 },
                    { 10, "ViewMedicalFiles", "fa fa-stethoscope", "Client", "Medical Files", true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(5021), 1, 10 },
                    { 11, "ViewRegister", "fa fa-registered", "Client", "Attendance Register", true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(5029), 1, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LayoutMenus_LayoutID",
                table: "LayoutMenus",
                column: "LayoutID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LayoutMenus");

            migrationBuilder.DropTable(
                name: "Layouts");

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 911, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 911, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 911, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 911, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 967, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 967, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 975, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 975, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 920, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 920, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 920, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 919, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 920, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 926, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 914, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 921, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 921, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 921, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 921, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 937, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 937, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 937, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 937, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 937, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 937, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 939, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 940, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 940, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 940, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 950, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 950, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 950, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 950, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 950, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 934, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 934, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 934, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 916, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 916, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 923, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 923, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 978, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 978, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 978, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 978, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 942, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 942, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 942, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 942, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 942, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 942, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 942, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 942, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 944, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 905, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 905, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 905, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 905, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 905, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 901, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 927, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 927, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 927, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 927, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 970, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 970, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 970, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 920, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 920, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 920, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 920, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 920, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 920, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 920, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 956, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 902, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 895, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 896, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 896, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 961, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 962, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 922, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 922, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 922, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 922, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 922, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 922, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 922, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 922, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 922, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 964, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 964, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 964, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 964, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 964, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 964, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 909, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 909, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 909, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 909, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 909, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 909, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 909, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 909, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 940, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 940, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 919, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 919, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 919, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 928, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 931, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 2, 22, 46, 42, 931, DateTimeKind.Local).AddTicks(6740));
        }
    }
}
