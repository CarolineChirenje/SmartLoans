using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class ClientTranscriptModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseTopicID",
                table: "ClientTranscripts");

            migrationBuilder.DropColumn(
                name: "DateRegistered",
                table: "ClientTranscripts");

            migrationBuilder.AddColumn<int>(
                name: "CourseSessionID",
                table: "ClientTranscripts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCompleted",
                table: "ClientTranscripts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 475, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 475, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 475, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 475, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 548, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 549, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 556, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 556, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 486, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 486, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 486, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 486, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 486, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 495, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 478, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 531, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 567, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 567, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 567, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 510, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 510, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 510, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 510, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 510, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 510, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 513, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 513, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 513, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 513, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 526, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 526, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 526, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 526, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 526, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 507, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 507, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 507, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 481, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 482, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 491, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 491, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 559, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 559, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 559, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 559, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 564, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 564, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 564, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 564, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 564, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 564, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 564, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 564, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 564, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 564, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 564, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 564, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 562, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 563, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 516, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 516, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 516, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 516, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 516, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 516, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 516, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 516, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 519, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 468, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 468, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 468, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 468, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 468, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 464, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 499, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 499, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 499, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 499, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 553, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 553, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 553, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 487, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 487, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 487, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 487, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 487, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 487, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 487, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 532, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 465, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 458, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 459, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 459, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 539, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 539, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 539, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 539, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 571, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 571, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 571, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 571, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 571, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 571, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 544, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 544, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 544, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 544, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 544, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 544, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 472, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 472, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 472, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 472, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 472, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 472, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 472, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 472, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 514, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 514, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 485, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 485, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 485, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 500, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 504, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 504, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 490, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 490, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 490, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 490, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 490, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 490, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 490, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 490, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 16, 33, 22, 490, DateTimeKind.Local).AddTicks(3534));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseSessionID",
                table: "ClientTranscripts");

            migrationBuilder.DropColumn(
                name: "DateCompleted",
                table: "ClientTranscripts");

            migrationBuilder.AddColumn<int>(
                name: "CourseTopicID",
                table: "ClientTranscripts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateRegistered",
                table: "ClientTranscripts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 67, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 67, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 67, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 67, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 150, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 150, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 157, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 157, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 82, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 82, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 82, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 82, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 82, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 95, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 71, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 135, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 168, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 168, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 168, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 114, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 114, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 114, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 114, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 114, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 114, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 117, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 118, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 118, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 118, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 130, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 130, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 130, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 130, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 130, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 110, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 110, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 110, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 75, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 75, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 88, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 88, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 160, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 160, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 160, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 160, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 165, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 165, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 165, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 165, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 165, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 165, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 165, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 165, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 165, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 165, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 165, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 165, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 163, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 163, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 121, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 121, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 121, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 121, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 121, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 121, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 121, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 121, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 124, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 56, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 56, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 56, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 56, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 56, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 51, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 100, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 100, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 100, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 100, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 154, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 154, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 154, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 83, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 83, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 83, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 83, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 83, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 83, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 83, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 136, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 52, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 44, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 45, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 45, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 144, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 144, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 144, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 144, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 171, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 171, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 171, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 171, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 171, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 171, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 147, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 147, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 147, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 147, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 147, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 147, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 62, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 62, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 62, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 62, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 62, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 62, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 62, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 62, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 119, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 119, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 80, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 80, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 80, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 102, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 107, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 107, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 87, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 87, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 87, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 87, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 87, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 87, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 87, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 87, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 11, 19, 12, 26, 28, 87, DateTimeKind.Local).AddTicks(6787));
        }
    }
}
