using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class CustomSettingsCleanUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomSettings_CustomSettingTypes_CustomSettingTypeID",
                table: "CustomSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomSettings_SystemVariableTypes_CustomVariableTypeID",
                table: "CustomSettings");

            migrationBuilder.DropTable(
                name: "CustomSettingTypes");

            migrationBuilder.DropIndex(
                name: "IX_CustomSettings_CustomSettingTypeID",
                table: "CustomSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SystemVariableTypes",
                table: "SystemVariableTypes");

            migrationBuilder.DropColumn(
                name: "CustomSettingTypeID",
                table: "CustomSettings");

            migrationBuilder.RenameTable(
                name: "SystemVariableTypes",
                newName: "VariableTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VariableTypes",
                table: "VariableTypes",
                column: "CustomVariableTypeID");

            migrationBuilder.CreateTable(
                name: "SupportLists",
                columns: table => new
                {
                    SupportListID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportLists", x => x.SupportListID);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalSupport",
                columns: table => new
                {
                    TechnicalSupportID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupportListID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalSupport", x => x.TechnicalSupportID);
                    table.ForeignKey(
                        name: "FK_TechnicalSupport_SupportLists_SupportListID",
                        column: x => x.SupportListID,
                        principalTable: "SupportLists",
                        principalColumn: "SupportListID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 224, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 224, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 224, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 224, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 269, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 269, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 273, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 273, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 231, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 231, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 231, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 231, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 231, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 236, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 226, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                columns: new[] { "IsActive", "LastChangedDate" },
                values: new object[] { false, new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 244, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 244, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 244, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 244, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 244, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 244, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 247, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 247, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 247, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 247, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 255, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 255, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 255, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 255, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 255, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 242, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 242, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 242, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 228, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 228, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 234, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 234, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 275, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 276, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 276, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 276, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "Products", new DateTime(2021, 5, 7, 22, 56, 5, 280, DateTimeKind.Local).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "PaidTransactions", new DateTime(2021, 5, 7, 22, 56, 5, 280, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                columns: new[] { "ActionName", "CSSClass", "LastChangedDate" },
                values: new object[] { "PendingTransactions", "fa fa-battery-empty", new DateTime(2021, 5, 7, 22, 56, 5, 280, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "Statements", new DateTime(2021, 5, 7, 22, 56, 5, 280, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "Courses", new DateTime(2021, 5, 7, 22, 56, 5, 280, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "Notes", new DateTime(2021, 5, 7, 22, 56, 5, 280, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 280, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 280, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "Contacts", new DateTime(2021, 5, 7, 22, 56, 5, 280, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "MedicalFiles", new DateTime(2021, 5, 7, 22, 56, 5, 280, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                columns: new[] { "ActionName", "CSSClass", "LastChangedDate" },
                values: new object[] { "AttendanceRegisters", "fa fa-pencil fa-fw", new DateTime(2021, 5, 7, 22, 56, 5, 280, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 278, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 278, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 249, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 249, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 249, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 249, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 249, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 249, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 249, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 249, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                columns: new[] { "DisplayName", "LastChangedDate" },
                values: new object[] { "Main Menu", new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "MenuGroupID", "OrderNo" },
                values: new object[] { 9995, "Layouts", "fa fa-bars", "Layouts", "Layout", true, "SuperUser", new DateTime(2021, 5, 7, 22, 56, 5, 251, DateTimeKind.Local).AddTicks(2653), 9998, 9995 });

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 219, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 219, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 219, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 219, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 219, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 238, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 238, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 238, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 238, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 271, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 271, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 271, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 231, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 231, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 231, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 231, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 231, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 231, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 231, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9772), 9996 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9773), 9997 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9775), 9998 });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[] { 24, "SuperUser", new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9776), 9999, 1 });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 217, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 212, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 213, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 213, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 264, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 264, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.InsertData(
                table: "SupportLists",
                columns: new[] { "SupportListID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, "SuperUser", new DateTime(2021, 5, 7, 22, 56, 5, 282, DateTimeKind.Local).AddTicks(3807), "MobileNumber" },
                    { 2, "SuperUser", new DateTime(2021, 5, 7, 22, 56, 5, 282, DateTimeKind.Local).AddTicks(3800), "CompanyRegistrationLink" },
                    { 1, "SuperUser", new DateTime(2021, 5, 7, 22, 56, 5, 282, DateTimeKind.Local).AddTicks(3235), "CompanyName" },
                    { 4, "SuperUser", new DateTime(2021, 5, 7, 22, 56, 5, 282, DateTimeKind.Local).AddTicks(3811), "Website" }
                });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 266, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 267, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 267, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 267, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 267, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 267, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 222, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 222, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 222, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 222, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 222, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 222, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 222, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 222, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 247, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 247, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 230, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 230, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 230, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "FirstName", "LastChangedDate" },
                values: new object[] { "Wadzanai Caroline", new DateTime(2021, 5, 7, 22, 56, 5, 238, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 240, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 240, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 233, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 233, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 233, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 233, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 233, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 233, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 233, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 233, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 22, 56, 5, 233, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 7, 22, 56, 5, 259, DateTimeKind.Local).AddTicks(9770), 9995 });

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalSupport_SupportListID",
                table: "TechnicalSupport",
                column: "SupportListID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomSettings_VariableTypes_CustomVariableTypeID",
                table: "CustomSettings",
                column: "CustomVariableTypeID",
                principalTable: "VariableTypes",
                principalColumn: "CustomVariableTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomSettings_VariableTypes_CustomVariableTypeID",
                table: "CustomSettings");

            migrationBuilder.DropTable(
                name: "TechnicalSupport");

            migrationBuilder.DropTable(
                name: "SupportLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VariableTypes",
                table: "VariableTypes");

            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995);

            migrationBuilder.RenameTable(
                name: "VariableTypes",
                newName: "SystemVariableTypes");

            migrationBuilder.AddColumn<int>(
                name: "CustomSettingTypeID",
                table: "CustomSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SystemVariableTypes",
                table: "SystemVariableTypes",
                column: "CustomVariableTypeID");

            migrationBuilder.CreateTable(
                name: "CustomSettingTypes",
                columns: table => new
                {
                    CustomSettingTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastChangedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomSettingTypes", x => x.CustomSettingTypeID);
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

            migrationBuilder.InsertData(
                table: "CustomSettingTypes",
                columns: new[] { "CustomSettingTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 233, DateTimeKind.Local).AddTicks(6485), "BackEnd" },
                    { 4, true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 233, DateTimeKind.Local).AddTicks(6605), "Email" },
                    { 3, true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 233, DateTimeKind.Local).AddTicks(6600), "All" },
                    { 2, true, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 233, DateTimeKind.Local).AddTicks(6594), "Portal" }
                });

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

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "ViewProducts", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "ViewTransactions", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                columns: new[] { "ActionName", "CSSClass", "LastChangedDate" },
                values: new object[] { "ViewPendingTransactions", "fa fa-credit-card-alt", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "GenerateStatement", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "ViewCourses", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "ViewNotes", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "ViewContacts", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "ViewMedicalFiles", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                columns: new[] { "ActionName", "CSSClass", "LastChangedDate" },
                values: new object[] { "ViewRegister", "fa fa-registered", new DateTime(2021, 5, 7, 14, 10, 41, 321, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 318, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 7, 14, 10, 41, 318, DateTimeKind.Local).AddTicks(8242));

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
                columns: new[] { "DisplayName", "LastChangedDate" },
                values: new object[] { "Menu", new DateTime(2021, 5, 7, 14, 10, 41, 266, DateTimeKind.Local).AddTicks(5329) });

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
                keyValue: 21,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6967), 9997 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6970), 9998 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6973), 9999 });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[] { 20, "SuperUser", new DateTime(2021, 5, 7, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6964), 9996, 1 });

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
                columns: new[] { "FirstName", "LastChangedDate" },
                values: new object[] { "Wadzanai", new DateTime(2021, 5, 7, 14, 10, 41, 240, DateTimeKind.Local).AddTicks(8049) });

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

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                columns: new[] { "CustomSettingTypeID", "IsActive", "LastChangedDate" },
                values: new object[] { 3, true, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 4, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 4, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 4, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 4, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 4, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 4, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 4, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                columns: new[] { "CustomSettingTypeID", "LastChangedDate" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 14, 10, 41, 280, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.CreateIndex(
                name: "IX_CustomSettings_CustomSettingTypeID",
                table: "CustomSettings",
                column: "CustomSettingTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomSettings_CustomSettingTypes_CustomSettingTypeID",
                table: "CustomSettings",
                column: "CustomSettingTypeID",
                principalTable: "CustomSettingTypes",
                principalColumn: "CustomSettingTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomSettings_SystemVariableTypes_CustomVariableTypeID",
                table: "CustomSettings",
                column: "CustomVariableTypeID",
                principalTable: "SystemVariableTypes",
                principalColumn: "CustomVariableTypeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
