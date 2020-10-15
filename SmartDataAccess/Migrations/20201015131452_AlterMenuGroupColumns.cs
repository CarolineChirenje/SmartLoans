using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class AlterMenuGroupColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientGuarantors");

            migrationBuilder.DeleteData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44);

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
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127);

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

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "MenuGroups");

            migrationBuilder.AddColumn<string>(
                name: "ActionName",
                table: "MenuGroups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ControllerName",
                table: "MenuGroups",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 500, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 501, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 501, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 501, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 515, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 515, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 515, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 515, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 515, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 524, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 505, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 518, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 518, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 518, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 518, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Allows system to hide exceptions and show custom error page to user", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(7997), "Show Custom Exceptions To Users", "true" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 4, "Limit Account Number Size", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(7958), "Account Number Length", "9" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 7, "Format Used to display date", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8005), "Date Format", "yyyy-MMM-dd" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                columns: new[] { "CustomSettingTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 4, "Port used to Send Emails", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8026), "Mail SMTP Port", "587" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                columns: new[] { "CustomSettingTypeID", "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 4, 2, "Host used to Send Emails", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8039), "Mail SMTP Host", "smtp.gmail.com" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Enable SSL", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8049), "Mail Enable SSL", "true" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Use Default Mail Credentials", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8059), "Mail Use Default Credentials", "false" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Email Address used to email", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8072), "Mail Credential User Name", "carolinesolutions89@gmail.com" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 8, "Email Password", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8180), "Mail Credential Password", "ZGNvaXpoeGlxenZ3dnphaw==" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                columns: new[] { "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { "Display Sender Name As", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8191), "Mail Display Name", "Smart Admin" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                columns: new[] { "CustomSettingTypeID", "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 3, 9, "Percentage To Which VAT is calculated on ", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8200), "VAT Percentage", "0.14" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                columns: new[] { "CustomSettingTypeID", "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 3, 6, "Maximum file size that can be uploaded to the System", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8210), "File Maximum UpLoadable Size", "5" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Account Number Prefix if Any", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(7968), "Account Number Prefix", "SS" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Short Name for Application", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(7931), "Application Name Prefix", "SS" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                columns: new[] { "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { "First Line on the Report Footer", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8224), "Report Footer 1", "W. Guri Mrs. (Chairman), *E. Guri (Managing)" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                columns: new[] { "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { "Additional Line on the Report Footer (can be blank)", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8233), "Report Footer 2", "*Executive." });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                columns: new[] { "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { "Foot notes that you would like to include on your statement (not mandatory)", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8243), "Report FootNotes", "" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Instructs the System to Advise User to Capture VAT inclusive amounts and calculate breakdown accordingly", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8253), "Capture VAT Inclusive Payments", "true" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                columns: new[] { "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { "Default Email Subject Name Used By Auto-Generated Emails", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8295), "Mail Default Subject", "Smart Save  Admin" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                columns: new[] { "Description", "LastChangedDate", "Name" },
                values: new object[] { "Allows to password protect statements being sent by Email", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8275), "Statement Password Protect" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Determines if table borders will be shown on the report ", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8286), "Statement Show Table Boarders", "true" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 4, "Password Reset Pin Code Length", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8349), "Password Reset Pin Code Length", "5" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 4, "Password Reset Pin Code Validity Period in Days", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8362), "Password Reset Pin Validity", "2" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Site URL", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8370), "Site URL", "https://localhost:5001" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                columns: new[] { "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { "Site Reset Password URL", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8382), "Site Reset Password URL", "https://localhost:5001/Login/ForgotPasswordConfirmation" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Customer Support Email", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8391), "Site Customer Service Email", "carochire@gmail.com" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Customer Support Number", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8402), "Site Customer Service Number", "0731143168" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Default Email Addresss that overrides Client Email Address in a Test Environment ", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8411), "Site Test Email Account", "carochire@gmail.com" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 4, "Current System Environment Set it to 1 For Test Environment  or 2 for Production Environment if no value has been set System defaults to Test Environment ", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8423), "Site Default Environment", "1" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Display menus based on User Role", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8437), "Application Role Based Menus", "false" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                columns: new[] { "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { "Site Client Create Account URL", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8446), "Site Create Account URL", "https://localhost:5001/Login/CreateAccountConfirmation" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 4, "Password Validity Period in Days", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8457), "Password Validity Period", "30" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Auto Generate Account Numbers", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8468), "Account Number Auto Generate", "true" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Allows System To Be VAT Compliant and Show calculated VAT Amounts ", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8479), "Application Is VAT Compliant", "false" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 7, "Format Used to display date time", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8016), "Date Format", "yyyy-MMM-dd HH:mm" });

            migrationBuilder.InsertData(
                table: "CustomSettings",
                columns: new[] { "CustomSettingID", "CustomSettingTypeID", "CustomVariableTypeID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name", "Value" },
                values: new object[] { 24, 3, 2, "Password Used to Open Password Protected Statement By System Administrators", true, "SuperUser", new DateTime(2020, 10, 15, 15, 14, 48, 565, DateTimeKind.Local).AddTicks(8264), "Statement Password For Admin", "123456" });

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 537, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 537, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 537, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 537, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 537, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 537, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 540, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 541, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 541, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 541, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 556, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 556, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 556, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 556, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 556, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 534, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 534, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 534, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 509, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 510, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 520, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 520, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                columns: new[] { "ActionName", "ControllerName", "LastChangedDate" },
                values: new object[] { "Dashboard", "Home", new DateTime(2020, 10, 15, 15, 14, 48, 544, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 544, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 544, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 544, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 544, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 544, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 544, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 548, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 489, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 489, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 489, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 489, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 489, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7676), "Add Client Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7683), "Update Client Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7690), "Delete Client Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7698), "View Client Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7707), "Add Client Medical Details" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7715), "Update Client Medical Details" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7725), "Delete Client Medical Details" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7738), "View Client Medical Details" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7746), "View Client Payments" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7754), "Generate Client Statement" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7761), "Client Upload Document" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7769), "Client View Document" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7779), "Add Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7785), "Update Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7792), "Delete Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7799), "View Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7806), "Add Permissions" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7814), "Remove Permissions" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7822), "View Permissions" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7831), "Add Menu To Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7839), "Remove Menu From Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7846), "Add Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7853), "Update Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7860), "Delete Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7869), "View Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7876), "Add Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7884), "Update Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7891), "Delete Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7898), "View Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7905), "Capture Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(7913), "Reverse Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8099), "View Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8111), "View Client Outstanding Payments" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8119), "Generate Invoices" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8127), "Remove Invoice Entries" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8135), "View Client Deductions" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8142), "Override Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8149), "Add Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8156), "Update Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8167), "Activate Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8175), "Deactivate Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8182), "Delete Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8189), "View Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8195), "Add Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8202), "Update Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8208), "Delete Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8215), "View Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8223), "View Course Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8231), "Add Course Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8238), "Update Course Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8245), "Delete Course Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8252), "Update Custom Setting" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8260), "View Custom Setting" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8268), "Add Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8275), "Update Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8282), "Delete Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8290), "View Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8297), "Add Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8304), "Update Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8311), "Delete Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8317), "View Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8325), "Add Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8333), "Update Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8340), "Delete Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8347), "View Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8355), "Add Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8362), "Update Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8369), "Delete Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8377), "View Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8384), "Add Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8391), "Update Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8397), "Delete Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8431), "View Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8439), "Update Country" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8447), "Update Currency" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8455), "View Dashboard Notices" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8463), "Client Update Personal Details" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8471), "Update Transaction Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8479), "View Transaction Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8487), "Add Product Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8494), "Update Product Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8502), "Delete Product Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8508), "View Product Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8516), "Add Product Assert" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8536), "Update Product Assert" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8544), "View Product Assert" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8551), "Add Assert" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8558), "Update Assert" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8566), "Delete Assert" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 14, 48, 482, DateTimeKind.Local).AddTicks(8573), "View Assert" });

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 525, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 525, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 525, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 525, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 516, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 516, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 516, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 516, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 516, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 516, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 567, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 484, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 471, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 474, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 474, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 519, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 519, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 519, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 519, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 519, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 519, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 519, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 519, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 519, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 496, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 496, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 496, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 496, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 496, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 496, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 496, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 496, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 541, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 541, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 514, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 514, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 514, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 527, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 530, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 15, 14, 48, 530, DateTimeKind.Local).AddTicks(8283));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24);

            migrationBuilder.DropColumn(
                name: "ActionName",
                table: "MenuGroups");

            migrationBuilder.DropColumn(
                name: "ControllerName",
                table: "MenuGroups");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MenuGroups",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClientGuarantors",
                columns: table => new
                {
                    ClientGuarantorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMainGuarantor = table.Column<bool>(type: "bit", nullable: false),
                    LastChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastChangedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientGuarantors", x => x.ClientGuarantorID);
                    table.ForeignKey(
                        name: "FK_ClientGuarantors_Clients_ClientID",
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
                value: new DateTime(2020, 10, 15, 13, 4, 30, 251, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 251, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 251, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 251, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 260, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 260, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 260, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 260, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 260, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 265, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 253, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 261, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 261, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 261, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 261, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 4, "Displays the minimum year that can be selected  from the system", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5837), "Minimum Year", "2000" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Allows system to BroadCast System Messages", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5843), "BroadCast Messages", "true" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Allows system to hide exceptions and show custom error page to user", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5849), "Show Custom Exceptions To Users", "true" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                columns: new[] { "CustomSettingTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 3, "Limit Account Number Size", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5822), "Account Number Length", "9" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                columns: new[] { "CustomSettingTypeID", "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 3, 7, "Format Used to display date", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5854), "Date Format", "yyyy-MMM-dd" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 4, "Port used to Send Emails", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5865), "Mail SMTP Port", "587" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Host used to Send Emails", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5870), "Mail SMTP Host", "smtp.gmail.com" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Enable SSL", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5875), "Mail Enable SSL", "true" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Use Default Mail Credentials", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5880), "Mail Use Default Credentials", "false" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                columns: new[] { "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { "Email Address used to email", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5913), "Mail Credential User Name", "carolinesolutions89@gmail.com" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                columns: new[] { "CustomSettingTypeID", "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 4, 8, "Email Password", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5966), "Mail Credential Password", "ZGNvaXpoeGlxenZ3dnphaw==" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                columns: new[] { "CustomSettingTypeID", "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 4, 2, "Display Sender Name As", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5973), "Mail Display Name", "Smart Admin" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 9, "Percentage To Which VAT is calculated on ", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5981), "VAT Percentage", "0.14" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 6, "Maximum file size that can be uploaded to the System", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5986), "File Maximum UpLoadable Size", "5" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                columns: new[] { "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { "Account Number Prefix if Any", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5828), "Account Number Prefix", "SS" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                columns: new[] { "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { "Short Name for Application", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5806), "Application Name Prefix", "SS" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                columns: new[] { "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { "First Line on the Report Footer", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5992), "Report Footer 1", "W. Guri Mrs. (Chairman), *E. Guri (Managing)" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Additional Line on the Report Footer (can be blank)", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5997), "Report Footer 2", "*Executive." });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                columns: new[] { "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { "Foot notes that you would like to include on your statement (not mandatory)", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6010), "Report FootNotes", "" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                columns: new[] { "Description", "LastChangedDate", "Name" },
                values: new object[] { "Instructs the System to Advise User to Capture VAT inclusive amounts and calculate breakdown accordingly", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6016), "Capture VAT Inclusive Payments" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Default Email Subject Name Used By Auto-Generated Emails", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6048), "Mail Default Subject", "Smart Save  Admin" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Option to Save Generated Statement To A physical Location on the Server", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6022), "Statement Save To Folder", "false" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Physical Location on the Server where  Statements Are Generated", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6027), "Statement Save To Physical Location", "C:\\SmartApp\\Statements" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Allows to password protect statements being sent by Email", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6038), "Statement Password Protect", "true" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                columns: new[] { "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { "Password Used to Open Password Protected Statement By System Administrators", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6033), "Statement Password For Admin", "123456" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Determines if table borders will be shown on the report ", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6043), "Statement Show Table Boarders", "true" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 4, "Password Reset Pin Code Length", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6054), "Password Reset Pin Code Length", "5" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 4, "Password Reset Pin Code Validity Period in Days", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6060), "Password Reset Pin Validity", "2" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Site URL", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6064), "Site URL", "https://localhost:5001" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Site Reset Password URL", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6071), "Site Reset Password URL", "https://localhost:5001/Login/ForgotPasswordConfirmation" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                columns: new[] { "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { "Customer Support Email", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6076), "Site Customer Service Email", "carochire@gmail.com" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Customer Support Number", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6082), "Site Customer Service Number", "0731143168" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 2, "Default Email Addresss that overrides Client Email Address in a Test Environment ", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6088), "Site Test Email Account", "carochire@gmail.com" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 4, "Current System Environment Set it to 1 For Test Environment  or 2 for Production Environment if no value has been set System defaults to Test Environment ", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6094), "Site Default Environment", "1" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                columns: new[] { "CustomVariableTypeID", "Description", "LastChangedDate", "Name", "Value" },
                values: new object[] { 1, "Display menus based on User Role", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6098), "Application Role Based Menus", "false" });

            migrationBuilder.InsertData(
                table: "CustomSettings",
                columns: new[] { "CustomSettingID", "CustomSettingTypeID", "CustomVariableTypeID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name", "Value" },
                values: new object[,]
                {
                    { 21, 3, 2, "Physical Location of Logo that is to be used on Reports", true, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6002), "Report Logo Path", "D:\\Dev Projects\\SmartSave\\SmartSave\\SmartResources\\SmartLogo.png" },
                    { 40, 3, 2, "Site Client Create Account URL", true, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6104), "Site Create Account URL", "https://localhost:5001/Login/CreateAccountConfirmation" },
                    { 41, 3, 4, "Password Validity Period in Days", true, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6108), "Password Validity Period", "30" },
                    { 42, 3, 1, "Auto Generate Account Numbers", true, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6113), "Account Number Auto Generate", "true" },
                    { 43, 3, 1, "Allows System To Be VAT Compliant and Show calculated VAT Amounts ", true, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(6119), "Application Is VAT Compliant", "true" },
                    { 44, 3, 7, "Format Used to display date time", true, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 291, DateTimeKind.Local).AddTicks(5860), "Date Format", "yyyy-MMM-dd HH:mm" }
                });

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 274, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 274, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 274, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 274, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 274, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 274, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 277, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 277, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 277, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 277, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 287, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 286, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 286, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 286, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 286, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 272, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 272, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 272, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 256, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 256, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 263, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 263, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 279, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 279, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 279, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 279, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 279, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 279, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 279, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 282, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 245, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 245, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 245, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 245, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 245, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 241, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(181), "Add Client Guarantor" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(186), "Update Client Guarantor" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(190), "Delete Client Guarantor" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(195), "View Client Guarantor" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(201), "Add Client Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(206), "Update Client Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(211), "Delete Client Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(219), "View Client Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(225), "Add Client Medical Details" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(248), "Update Client Medical Details" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(253), "Delete Client Medical Details" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(259), "View Client Medical Details" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(264), "View Client Payments" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(269), "Generate Client Statement" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(274), "Client Upload Document" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(279), "Client View Document" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(284), "Add Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(288), "Update Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(293), "Delete Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(298), "View Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(303), "Add Permissions" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(308), "Remove Permissions" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(313), "View Permissions" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(319), "Add Menu To Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(325), "Remove Menu From Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(329), "Add Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(334), "Update Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(339), "Delete Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(343), "View Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(348), "Add Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(353), "Update Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(358), "Delete Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(363), "View Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(368), "Respond To Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(373), "Route Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(378), "Suspend Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(383), "Close Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(387), "Capture Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(393), "Refund Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(400), "Reverse Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(405), "Void Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(409), "View Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(414), "Make Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(419), "Add Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(423), "Update Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(428), "Activate Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(433), "Deactivate Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(438), "Delete Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(442), "View Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(457), "Add Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(462), "Update Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(467), "Delete Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(471), "View Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(476), "Update Custom Setting" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(481), "View Custom Setting" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(486), "Add Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(492), "Update Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(496), "Delete Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(502), "View Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(506), "Add Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(511), "Update Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(515), "Delete Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(520), "View Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(525), "Add Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(530), "Update Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(535), "Delete Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(540), "View Bank Account" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(545), "Add Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(550), "Update Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(555), "Delete Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(561), "View Email Template" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(566), "Add Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(571), "Update Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(575), "Delete Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(580), "View Notice" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(585), "Update Country" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(590), "Update Currency" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(595), "View Dashboard Notices" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(601), "Client Update Personal Details" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(606), "Update Transaction Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(611), "View Transaction Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(616), "Add Product Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(621), "Update Product Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(626), "Delete Product Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(631), "View Product Fee" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(636), "Add Product Assert" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(641), "Update Product Assert" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(646), "View Product Assert" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(651), "Add Assert" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(655), "Update Assert" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 119, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(671), "View Client Outstanding Payments" },
                    { 125, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(711), "Add Course Fee" },
                    { 124, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(706), "View Course Fee" },
                    { 123, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(701), "Override Payment" },
                    { 122, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(696), "View Client Deductions" },
                    { 121, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(680), "Remove Invoice Entries" },
                    { 127, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(720), "Delete Course Fee" },
                    { 118, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(664), "View Assert" },
                    { 117, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(660), "Delete Assert" },
                    { 126, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(716), "Update Course Fee" },
                    { 120, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(675), "Generate Invoices" }
                });

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 266, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 266, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 266, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 266, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 260, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 260, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 260, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 260, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 260, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 260, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 292, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 235, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 236, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 236, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 262, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 262, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 262, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 262, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 262, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 262, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 262, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 262, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 262, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 248, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 248, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 248, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 248, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 248, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 248, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 248, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 248, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 277, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 277, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 259, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 259, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 259, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 267, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 269, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 13, 4, 30, 269, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[,]
                {
                    { 117, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9055), 117, 1 },
                    { 118, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9057), 118, 1 },
                    { 119, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9059), 119, 1 },
                    { 120, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9061), 120, 1 },
                    { 121, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9063), 121, 1 },
                    { 122, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9065), 122, 1 },
                    { 123, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9067), 123, 1 },
                    { 124, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9069), 124, 1 },
                    { 125, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9071), 125, 1 },
                    { 126, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9073), 126, 1 },
                    { 127, "SuperUser", new DateTime(2020, 10, 15, 13, 4, 30, 242, DateTimeKind.Local).AddTicks(9075), 127, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientGuarantors_ClientID",
                table: "ClientGuarantors",
                column: "ClientID");
        }
    }
}
