using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class ProductComputationAlterations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "PluginName",
                table: "ProductComputations",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProductComputations",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Method",
                table: "ProductComputations",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 760, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 760, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 760, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 760, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "CalculationTypes",
                keyColumn: "CalculationTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 847, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "CalculationTypes",
                keyColumn: "CalculationTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 847, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 816, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 816, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 821, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 821, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 767, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 767, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 767, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 767, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 767, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 775, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 763, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 832, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 832, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 832, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 787, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 787, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 787, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 787, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 787, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 787, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 790, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 790, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 790, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 790, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 799, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 799, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 799, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 799, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 799, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 783, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 783, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 783, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 849, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 849, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 849, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 849, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 849, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 849, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 849, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 849, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 772, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 772, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 824, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 824, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 824, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 824, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 830, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 827, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 827, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 827, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 827, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 827, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 827, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 827, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 844, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 844, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 844, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 793, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 793, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 793, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 793, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 793, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 793, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 793, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 793, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 793, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 794, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 794, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 794, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 794, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 794, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 794, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 794, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 794, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 794, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 794, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 755, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 755, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 755, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 755, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 755, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 842, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 842, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 842, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 842, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 842, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 842, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6737), "Update Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6747), "View Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6759), "Add Loan Status" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6771), "Update Loan Status" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6781), "Delete Loan Status" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6887), "View Loan Status" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6900), "Add Category" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6911), "Update Category" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6923), "Delete Category" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6933), "View Category" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6944), "Add Loan" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6955), "Update Loan" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6973), "Delete Loan" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6982), "View Loan" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(6995), "Add Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7007), "Update Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7017), "View Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7026), "Delete Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7036), "Update Product Computation" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7047), "View Product Computation" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7058), "Loan Upload Document" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7070), "Loan View Document" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7082), "Add Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7092), "Update Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7104), "View Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7115), "Delete Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7126), "Add Fiscal Year" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7137), "Update Fiscal Year" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7148), "View Fiscal Year" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 14, 27, 57, 751, DateTimeKind.Local).AddTicks(7159), "Delete Fiscal Year" });

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 836, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 836, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 836, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 778, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 778, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 778, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 778, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.InsertData(
                table: "ProductComputations",
                columns: new[] { "ProductComputationID", "CreatedBy", "DateCreated", "IsActive", "LastChangedBy", "LastChangedDate", "Method", "Name", "PluginName" },
                values: new object[,]
                {
                    { 2, "SuperUser", new DateTime(2022, 4, 11, 14, 27, 57, 852, DateTimeKind.Local).AddTicks(2644), true, "SuperUser", new DateTime(2022, 4, 11, 14, 27, 57, 852, DateTimeKind.Local).AddTicks(2691), null, "Type 2", null },
                    { 1, "SuperUser", new DateTime(2022, 4, 11, 14, 27, 57, 852, DateTimeKind.Local).AddTicks(997), true, "SuperUser", new DateTime(2022, 4, 11, 14, 27, 57, 852, DateTimeKind.Local).AddTicks(1754), null, "Type 1", null }
                });

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 818, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 818, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 818, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 768, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 768, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 768, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 768, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 768, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 768, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 768, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 804, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 752, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 741, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 746, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 746, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 810, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 810, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 810, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 810, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 834, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 834, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 834, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 834, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 834, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 834, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 834, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 813, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 813, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 813, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 813, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 813, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 813, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 758, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 758, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 758, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 758, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 758, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 758, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 758, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 758, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 790, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 790, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 766, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 766, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 766, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 779, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 780, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 780, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 771, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 771, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 771, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 771, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 771, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 771, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 771, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 771, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 14, 27, 57, 771, DateTimeKind.Local).AddTicks(3572));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductComputations",
                keyColumn: "ProductComputationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductComputations",
                keyColumn: "ProductComputationID",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "PluginName",
                table: "ProductComputations",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProductComputations",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Method",
                table: "ProductComputations",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 637, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 637, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 637, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 637, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "CalculationTypes",
                keyColumn: "CalculationTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 670, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "CalculationTypes",
                keyColumn: "CalculationTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 670, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 657, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 657, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 659, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 659, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 640, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 640, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 640, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 640, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 640, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 642, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 638, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 652, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 663, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 663, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 663, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 646, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 646, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 646, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 646, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 646, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 646, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 647, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 647, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 647, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 647, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 650, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 650, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 650, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 650, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 650, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 645, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 645, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 645, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 671, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 671, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 671, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 671, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 671, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 671, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 671, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 671, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 641, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 641, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 660, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 660, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 660, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 660, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 662, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 661, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 661, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 661, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 661, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 661, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 661, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 661, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 669, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 669, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 669, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 648, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 635, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 635, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 635, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 635, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 635, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 668, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 668, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 668, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 668, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 668, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 668, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8810), "Add Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8814), "Update Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8818), "Delete Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8822), "View Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8826), "Add Loan Status" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8830), "Update Loan Status" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8834), "Delete Loan Status" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8838), "View Loan Status" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8842), "Add Category" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8846), "Update Category" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8849), "Delete Category" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8853), "View Category" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8858), "Add Loan" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8862), "Update Loan" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8865), "Delete Loan" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8869), "View Loan" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8873), "Add Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8877), "Update Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8881), "View Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8885), "Delete Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8889), "Add Product Computation" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8893), "Update Product Computation" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8897), "View Product Computation" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8901), "Delete Product Computation" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8905), "Loan Upload Document" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8909), "Loan View Document" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8913), "Add Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8917), "Update Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8922), "View Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8925), "Delete Loan Note" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 149, null, true, false, "SuperUser", new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8933), "Update Fiscal Year" },
                    { 150, null, true, false, "SuperUser", new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8957), "View Fiscal Year" },
                    { 151, null, true, false, "SuperUser", new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8961), "Delete Fiscal Year" },
                    { 148, null, true, false, "SuperUser", new DateTime(2022, 4, 11, 12, 35, 43, 633, DateTimeKind.Local).AddTicks(8929), "Add Fiscal Year" }
                });

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 665, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 665, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 665, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 643, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 643, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 643, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 643, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 658, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 658, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 658, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 640, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 640, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 640, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 640, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 640, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 640, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 640, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 653, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 653, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 653, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 653, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 653, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 653, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 653, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 653, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 653, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 653, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 630, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 632, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 632, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 655, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 655, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 655, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 655, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 664, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 664, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 664, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 664, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 664, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 664, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 664, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 656, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 656, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 656, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 656, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 656, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 656, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 636, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 636, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 636, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 636, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 636, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 636, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 636, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 636, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 647, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 647, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 639, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 639, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 639, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 644, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 644, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 644, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 641, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 641, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 641, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 641, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 641, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 641, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 641, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 641, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 12, 35, 43, 641, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[,]
                {
                    { 148, "SuperUser", new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2202), 148, 1 },
                    { 149, "SuperUser", new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2204), 149, 1 },
                    { 150, "SuperUser", new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2206), 150, 1 },
                    { 151, "SuperUser", new DateTime(2022, 4, 11, 12, 35, 43, 634, DateTimeKind.Local).AddTicks(2236), 151, 1 }
                });
        }
    }
}
