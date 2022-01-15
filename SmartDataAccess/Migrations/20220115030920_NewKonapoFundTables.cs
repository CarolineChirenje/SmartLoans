using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class NewKonapoFundTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FundItems",
                columns: table => new
                {
                    FundItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundItems", x => x.FundItemID);
                });

            migrationBuilder.CreateTable(
                name: "Funds",
                columns: table => new
                {
                    FundID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funds", x => x.FundID);
                });

            migrationBuilder.CreateTable(
                name: "FundSources",
                columns: table => new
                {
                    FundSourceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundSources", x => x.FundSourceID);
                });

            migrationBuilder.CreateTable(
                name: "KonapoFundHistories",
                columns: table => new
                {
                    KonapoFundHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    KonapoFundID = table.Column<int>(nullable: false),
                    FundSourceID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ProjectedCost = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    KonapoAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonapoFundHistories", x => x.KonapoFundHistoryID);
                });

            migrationBuilder.CreateTable(
                name: "FundCategories",
                columns: table => new
                {
                    FundCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    FundID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundCategories", x => x.FundCategoryID);
                    table.ForeignKey(
                        name: "FK_FundCategories_Funds_FundID",
                        column: x => x.FundID,
                        principalTable: "Funds",
                        principalColumn: "FundID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KonapoFunds",
                columns: table => new
                {
                    KonapoFundID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    FundID = table.Column<int>(nullable: false),
                    FundSourceID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ProjectedCost = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    KonapoAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonapoFunds", x => x.KonapoFundID);
                    table.ForeignKey(
                        name: "FK_KonapoFunds_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KonapoFunds_Funds_FundID",
                        column: x => x.FundID,
                        principalTable: "Funds",
                        principalColumn: "FundID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KonapoFunds_FundSources_FundSourceID",
                        column: x => x.FundSourceID,
                        principalTable: "FundSources",
                        principalColumn: "FundSourceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FundCategoryItems",
                columns: table => new
                {
                    FundCategoryItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    FundItemID = table.Column<int>(nullable: false),
                    FundCategoryID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundCategoryItems", x => x.FundCategoryItemID);
                    table.ForeignKey(
                        name: "FK_FundCategoryItems_FundCategories_FundCategoryID",
                        column: x => x.FundCategoryID,
                        principalTable: "FundCategories",
                        principalColumn: "FundCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FundCategoryItems_FundItems_FundItemID",
                        column: x => x.FundItemID,
                        principalTable: "FundItems",
                        principalColumn: "FundItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 854, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 854, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 854, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 854, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 891, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 891, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 894, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 894, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 902, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 902, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 902, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 870, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 870, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 870, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 870, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 870, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 870, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 871, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 872, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 872, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 872, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 880, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 880, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 880, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 880, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 880, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 868, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 868, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 868, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 858, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 858, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.InsertData(
                table: "FundSources",
                columns: new[] { "FundSourceID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, true, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 906, DateTimeKind.Local).AddTicks(5440), "Cash" },
                    { 1, true, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 906, DateTimeKind.Local).AddTicks(4994), "Bank" }
                });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 896, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 896, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 896, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 896, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 898, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 898, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.InsertData(
                table: "MenuGroups",
                columns: new[] { "MenuGroupID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "IsActiveMenu", "LastChangedBy", "LastChangedDate", "OrderNo" },
                values: new object[] { 8, null, "fa search-dollar", null, "Konapo Fund", true, false, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8753), 8 });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 849, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 849, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 849, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 849, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 849, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 154, null, true, false, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2057), "View Fund Item" },
                    { 149, null, true, false, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2026), "Delete Fund" },
                    { 152, null, true, false, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2045), "Update Fund Item" },
                    { 151, null, true, false, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2039), "Add Fund Item" },
                    { 147, null, true, false, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2014), "Add Fund" },
                    { 148, null, true, false, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2020), "Update Fund" },
                    { 153, null, true, false, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2051), "Delete Fund Item" },
                    { 150, null, true, false, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2032), "View Fund" }
                });

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 865, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 865, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 865, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 865, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 892, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 892, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 892, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9177), 9994 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9181), 9995 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9185), 9996 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 26,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9189), 9997 });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[,]
                {
                    { 27, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9193), 9998, 1 },
                    { 28, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9197), 9999, 1 }
                });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 838, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 842, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 842, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 888, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 888, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 888, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 888, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 904, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 904, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 904, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 904, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 904, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 904, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 889, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 889, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 889, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 889, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 889, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 889, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 872, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 872, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 859, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 859, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 859, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 866, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 867, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 867, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "MenuGroupID", "OrderNo" },
                values: new object[,]
                {
                    { 22, "Fund", "fas fa-funnel-dollar", "Fund", "Konapo Funds", true, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2166), 8, 22 },
                    { 23, "FundItems", "fas fa-list", "FundItem", "Fund Items", true, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2174), 8, 23 }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[,]
                {
                    { 147, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8712), 147, 1 },
                    { 148, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8716), 148, 1 },
                    { 149, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8720), 149, 1 },
                    { 150, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8724), 150, 1 },
                    { 151, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8727), 151, 1 },
                    { 152, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8731), 152, 1 },
                    { 153, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8735), 153, 1 },
                    { 154, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8739), 154, 1 }
                });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9169), 22 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9173), 23 });

            migrationBuilder.CreateIndex(
                name: "IX_FundCategories_FundID",
                table: "FundCategories",
                column: "FundID");

            migrationBuilder.CreateIndex(
                name: "IX_FundCategoryItems_FundCategoryID",
                table: "FundCategoryItems",
                column: "FundCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FundCategoryItems_FundItemID",
                table: "FundCategoryItems",
                column: "FundItemID");

            migrationBuilder.CreateIndex(
                name: "IX_KonapoFunds_ClientID",
                table: "KonapoFunds",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_KonapoFunds_FundID",
                table: "KonapoFunds",
                column: "FundID");

            migrationBuilder.CreateIndex(
                name: "IX_KonapoFunds_FundSourceID",
                table: "KonapoFunds",
                column: "FundSourceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FundCategoryItems");

            migrationBuilder.DropTable(
                name: "KonapoFundHistories");

            migrationBuilder.DropTable(
                name: "KonapoFunds");

            migrationBuilder.DropTable(
                name: "FundCategories");

            migrationBuilder.DropTable(
                name: "FundItems");

            migrationBuilder.DropTable(
                name: "FundSources");

            migrationBuilder.DropTable(
                name: "Funds");

            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 168, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 168, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 168, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 168, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 250, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 250, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 258, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 258, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 181, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 181, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 181, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 181, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 181, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 189, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 190, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 172, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 231, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 269, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 270, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 270, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 206, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 206, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 206, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 206, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 206, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 206, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 210, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 210, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 210, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 210, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 225, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 224, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 224, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 224, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 224, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 202, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 202, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 202, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 176, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 176, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 186, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 186, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 261, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 261, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 261, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 261, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 266, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 266, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 266, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 266, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 266, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 266, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 266, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 266, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 266, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 266, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 266, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 266, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 264, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 264, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 213, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 213, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 213, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 213, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 213, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 213, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 213, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 213, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 213, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 216, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 159, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 160, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 160, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 160, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 160, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 155, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 193, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 193, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 193, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 193, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 255, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 255, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 255, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 182, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 182, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 182, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 182, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 182, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 182, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 182, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8268), 9996 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8270), 9997 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8273), 9998 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 26,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8275), 9999 });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[,]
                {
                    { 21, "SuperUser", new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8263), 9994, 1 },
                    { 22, "SuperUser", new DateTime(2021, 11, 19, 19, 20, 51, 232, DateTimeKind.Local).AddTicks(8266), 9995, 1 }
                });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 156, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 150, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 150, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 150, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 241, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 241, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 241, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 241, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 272, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 272, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 272, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 272, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 272, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 272, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 245, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 245, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 245, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 245, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 245, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 245, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 163, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 163, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 163, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 163, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 163, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 163, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 163, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 163, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 211, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 211, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 179, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 180, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 180, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 194, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 198, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 198, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 185, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 185, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 185, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 185, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 185, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 185, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 185, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 185, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 19, 20, 51, 185, DateTimeKind.Local).AddTicks(7888));
        }
    }
}
